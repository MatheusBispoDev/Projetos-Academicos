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
import model.Materiais;

/**
 *
 * @author Michael
 */
public class MaterialDAO {
    public void create(Materiais m) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_materiais (codigo,nome,descr,valor,img)VALUES(?,?,?,?,?)");
            stmt.setInt(1, m.getCodigo());
            stmt.setString(2, m.getNome());
            stmt.setString(3, m.getDescr());
            stmt.setDouble(4, m.getValor());
            stmt.setString(5, m.getImg());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    /**
     *
     * @return
     */
    public List<Materiais> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Materiais> materiais = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_materiais");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Materiais material = new Materiais();

                material.setCodigo(rs.getInt("codigo"));
                material.setNome(rs.getString("nome"));
                material.setDescr(rs.getString("descr"));
                material.setValor(rs.getDouble("valor"));  
                material.setImg(rs.getString("img"));
                materiais.add(material);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Materiais.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return materiais;
    }
    
    public List<Materiais> readForDesc(String nome) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Materiais> materiais = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_materiais WHERE nome LIKE ?");
            stmt.setString(1, "%"+nome+"%");
            
            rs = stmt.executeQuery();

            while (rs.next()) {

                Materiais material = new Materiais();

                material.setCodigo(rs.getInt("codigo"));
                material.setNome(rs.getString("nome"));
                material.setDescr(rs.getString("descr"));
                material.setValor(rs.getDouble("valor")); 
                material.setImg(rs.getString("imagem"));
                materiais.add(material);
            }

        } catch (SQLException ex) {
            Logger.getLogger(MaterialDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return materiais;
    }
    public int read_cod_prato(String nome) {
        Connection con = ConnectionFactory.getConnection();
        int cod = -1;
        PreparedStatement stmt = null;
        ResultSet rs = null;       

        try {
            stmt = con.prepareStatement("SELECT codigo FROM tb_materiais WHERE nome=?");
            stmt.setString(1,nome);        
           
            rs = stmt.executeQuery();            
            
            while (rs.next()) {     
                Materiais material = new Materiais();
                material.setCodigo(rs.getInt("codigo"));  
                cod = material.getCodigo();                
            }           
        } catch (SQLException ex) {
            Logger.getLogger(MaterialDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }        
        return cod;
    }
    public void update(Materiais m) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_materiais SET nome = ?,descr = ?,valor = ?,img = ? WHERE codigo = ?");            
            stmt.setString(1, m.getNome());
            stmt.setString(2, m.getDescr());
            stmt.setDouble(3, m.getValor());
            stmt.setString(4, m.getImg());
            stmt.setInt(5, m.getCodigo());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public void delete(Materiais m) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("DELETE FROM tb_materiais WHERE codigo = ?");
            stmt.setInt(1, m.getCodigo());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Excluido com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao excluir: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }       
}


