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
import model.Funcionario;


/**
 *
 * @author Francisco
 */

public class FuncionarioDAO {
    public void create(Funcionario f) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_funcionario (rg,empresa,nome,telefone,endereco,num,cep,foto,cargo)VALUES(?,?,?,?,?,?,?,?,?)");
            stmt.setString(1, f.getRg());
            stmt.setInt(2, f.getEmpresa());
            stmt.setString(3, f.getNome());
            stmt.setString(4, f.getTelefone());
            stmt.setString(5, f.getEndereco());
            stmt.setInt(6, f.getNum());
            stmt.setString(7, f.getCep());
            stmt.setString(8, f.getImg());
            stmt.setString(9, f.getCargo());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Funcionario> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Funcionario> funcionarios = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_funcionario");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Funcionario funcionario = new Funcionario();

                funcionario.setRg(rs.getString("rg"));
                funcionario.setEmpresa(rs.getInt("empresa"));
                funcionario.setNome(rs.getString("nome"));  
                funcionario.setTelefone(rs.getString("telefone"));
                funcionario.setEndereco(rs.getString("Endereco"));
                funcionario.setNum(rs.getInt("num"));
                funcionario.setCep(rs.getString("cep"));
                funcionario.setImg(rs.getString("foto"));
                funcionario.setCargo(rs.getString("cargo"));
                funcionarios.add(funcionario);
            }

        } catch (SQLException ex) {
            Logger.getLogger(FuncionarioDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return funcionarios;
    }
    
        public List<Funcionario> readForDesc(String nome) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Funcionario> funcionarios = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_funcionario WHERE nome LIKE ?");
            stmt.setString(1, "%"+nome+"%");
            
            rs = stmt.executeQuery();

            while (rs.next()) {

                Funcionario funcionario = new Funcionario();

                funcionario.setRg(rs.getString("rg"));
                funcionario.setEmpresa(rs.getInt("empresa"));
                funcionario.setNome(rs.getString("nome"));  
                funcionario.setTelefone(rs.getString("telefone"));
                funcionario.setEndereco(rs.getString("Endereco"));
                funcionario.setNum(rs.getInt("num"));
                funcionario.setCep(rs.getString("cep"));
                funcionario.setImg(rs.getString("foto"));
                funcionario.setCargo(rs.getString("cargo"));
                funcionarios.add(funcionario);
            }

        } catch (SQLException ex) {
            Logger.getLogger(FuncionarioDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return funcionarios;
    }
        
    public void update(Funcionario f) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_funcionario SET empresa = ?,nome = ?,telefone = ?,endereco = ?,num = ?,cep = ?,foto = ?,cargo = ? WHERE rg = ?");            
            stmt.setInt(1, f.getEmpresa());
            stmt.setString(2, f.getNome());
            stmt.setString(3, f.getTelefone());
            stmt.setString(4, f.getEndereco());
            stmt.setInt(5, f.getNum());
            stmt.setString(6, f.getCep());
            stmt.setString(7, f.getImg());
            stmt.setString(8, f.getCargo());
            stmt.setString(9, f.getRg());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public void delete(Funcionario f) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("DELETE FROM tb_funcionario WHERE rg = ?");
            stmt.setString(1, f.getRg());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Excluido com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao excluir: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }    
    
    public boolean validar(String rg) {
        Connection con = ConnectionFactory.getConnection();        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        boolean val = false;
        
        try {
            stmt = con.prepareStatement("Select * FROM tb_funcionario WHERE rg = ?");
            stmt.setString(1, rg);

             rs = stmt.executeQuery();

            if (rs.next()) {                
                val = true;
            }
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao validar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
        return val;
    }
    public Funcionario readRg(String rg) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;
        Funcionario funcionario = new Funcionario();
        
        try {
            stmt = con.prepareStatement("SELECT * FROM tb_funcionario WHERE rg = ?");
            stmt.setString(1, rg);
            
            rs = stmt.executeQuery();
            
            while (rs.next()) {
                funcionario.setRg(rs.getString("rg"));
                funcionario.setEmpresa(rs.getInt("empresa"));
                funcionario.setNome(rs.getString("nome"));  
                funcionario.setTelefone(rs.getString("telefone"));
                funcionario.setEndereco(rs.getString("Endereco"));
                funcionario.setNum(rs.getInt("num"));
                funcionario.setCep(rs.getString("cep"));
                funcionario.setImg(rs.getString("foto"));
                funcionario.setCargo(rs.getString("cargo"));
                
            }

        } catch (SQLException ex) {
            Logger.getLogger(FuncionarioDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return funcionario;
    }
}



    

