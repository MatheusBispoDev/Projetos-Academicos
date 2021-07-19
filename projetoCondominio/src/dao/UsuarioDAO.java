/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import factory.ConnectionFactory;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import model.Usuario;

/**
 *
 * @author Familia Coelho
 */
public class UsuarioDAO {
    
    public void create(Usuario u) {
        Connection con = ConnectionFactory.getConnection();
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_usuarios (login,senha,nivel_acesso)VALUES(?,?,?)");
            stmt.setString(1, u.getLogin());
            stmt.setString(2, u.getSenha());
            stmt.setString(3, u.getNivel_Acesso());            

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Usuario> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Usuario> usuarios = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_usuarios");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Usuario usuario = new Usuario();

                usuario.setLogin(rs.getString("login"));
                usuario.setSenha(rs.getString("senha"));
                usuario.setNivel_Acesso(rs.getString("nivel_acesso"));  
                
                usuarios.add(usuario);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Usuario.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return usuarios;
    }
    
    public String read_NivelAcesso(String login){
        Connection con = ConnectionFactory.getConnection();        
        PreparedStatement stmt = null;
        ResultSet rs = null;
        String nivel="";

        try {
            stmt = con.prepareStatement("SELECT nivel_acesso FROM tb_usuarios where login = ?");
            stmt.setString(1, login);
            
            rs = stmt.executeQuery();

            while (rs.next()) {
                Usuario usuario = new Usuario();
                
                usuario.setNivel_Acesso(rs.getString("nivel_acesso"));  
                nivel = usuario.getNivel_Acesso();
            }
        } catch (SQLException ex) {
            Logger.getLogger(Usuario.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return nivel;
    }
    
    public void update(Usuario p) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_usuarios SET senha = ?, nivel_acesso = ? WHERE login = ?");            
            stmt.setString(1, p.getSenha());
            stmt.setString(2, p.getNivel_Acesso());  
            stmt.setString(3, p.getLogin());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public boolean validar_usuario(String login, String senha) {
        Connection con = ConnectionFactory.getConnection();
        PreparedStatement stmt = null;
        ResultSet rs = null;

        boolean val = false;

        try {            
            stmt = con.prepareStatement("SELECT * FROM tb_usuarios WHERE login = ? and senha = ?");
            stmt.setString(1, login);
            stmt.setString(2, senha);

            rs = stmt.executeQuery();

            if (rs.next()) {                
                val = true;
            }

        } catch (SQLException ex) {
            Logger.getLogger(UsuarioDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }

        return val;
    }
}
