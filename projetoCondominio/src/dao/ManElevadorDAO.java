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
import model.Manutencao_Ele;

/**
 *
 * @author Michael
 */
public class ManElevadorDAO {
    public void create(Manutencao_Ele m) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_manutencao_ele (codigo,condominio,data_manu,elevador,empresa_respo,descr)VALUES(?,?,?,?,?,?)");
            stmt.setInt(1, m.getCodigo());
            stmt.setInt(2, m.getCondominio());
            stmt.setString(3, m.getData_Manu());
            stmt.setString(4, m.getElevador());
            stmt.setString(5, m.getEmpresa_respo());
            stmt.setString(6, m.getDescr());

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
    public List<Manutencao_Ele> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Manutencao_Ele> manutencao = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_manutencao_ele");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Manutencao_Ele mmanutencao = new Manutencao_Ele();

                mmanutencao.setCodigo(rs.getInt("codigo"));
                mmanutencao.setCondominio(rs.getInt("condominio"));
                mmanutencao.setData_Manu(rs.getString("data_manu"));
                mmanutencao.setElevador(rs.getString("elevador"));  
                mmanutencao.setEmpresa_respo(rs.getString("empresa_respo"));
                mmanutencao.setDescr(rs.getString("descr"));
                manutencao.add(mmanutencao);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Manutencao_Ele.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return manutencao;
    }
    
    public List<Manutencao_Ele> readForDesc(String condominio) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Manutencao_Ele> manutencao = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_manutencao_ele WHERE condominio LIKE ?");
            stmt.setString(1, "%"+condominio+"%");
            
            rs = stmt.executeQuery();

            while (rs.next()) {

                Manutencao_Ele mmanutencao = new Manutencao_Ele();

                mmanutencao.setCodigo(rs.getInt("codigo"));
                mmanutencao.setCondominio(rs.getInt("condominio"));
                mmanutencao.setData_Manu(rs.getString("data_manu"));
                mmanutencao.setElevador(rs.getString("elevador"));  
                mmanutencao.setEmpresa_respo(rs.getString("empresa_respo"));
                mmanutencao.setDescr(rs.getString("descr"));
                manutencao.add(mmanutencao);
            }

        } catch (SQLException ex) {
            Logger.getLogger(ManElevadorDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return manutencao;
    }
    
    public void update(Manutencao_Ele m) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_manutencao_ele SET condominio = ?,data_manu = ?,elevador = ?,empresa_respo = ?,descr = ? WHERE codigo = ?");            
            stmt.setInt(1, m.getCondominio());
            stmt.setString(2, m.getData_Manu());
            stmt.setString(3, m.getElevador());
            stmt.setString(4, m.getEmpresa_respo());
            stmt.setString(5, m.getDescr());
            stmt.setInt(6, m.getCodigo());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public void delete(Manutencao_Ele m) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("DELETE FROM tb_manutencao_ele WHERE codigo = ?");
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
