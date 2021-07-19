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
import model.Dedetizacao;

/**
 *
 * @author Michael
 */
public class DedetizacaoDAO {
    public void create(Dedetizacao d) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_dedetizacao (codigo,condominio,empresa_resp,data_dede,descricao)VALUES(?,?,?,?,?)");
            stmt.setInt(1, d.getCodigo());
            stmt.setInt(2, d.getCondominio());
            stmt.setString(3, d.getEmpresa_resp());
            stmt.setString(4, d.getData_dede());
            stmt.setString(5, d.getDescricao());

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
    public List<Dedetizacao> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Dedetizacao> dedetizacao = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_dedetizacao");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Dedetizacao ddedetizacao = new Dedetizacao();

                ddedetizacao.setCodigo(rs.getInt("codigo"));
                ddedetizacao.setCondominio(rs.getInt("condominio"));
                ddedetizacao.setEmpresa_resp(rs.getString("empresa_resp"));
                ddedetizacao.setData_dede(rs.getString("data_dede"));  
                ddedetizacao.setDescricao(rs.getString("descricao"));
                dedetizacao.add(ddedetizacao);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Dedetizacao.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return dedetizacao;
    }
    
    public List<Dedetizacao> readForDesc(String condominio) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Dedetizacao> dedetizacao = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_dedetizacao WHERE condominio LIKE ?");
            stmt.setString(1, "%"+condominio+"%");
            
            rs = stmt.executeQuery();

            while (rs.next()) {

                Dedetizacao ddedetizacao = new Dedetizacao();

                ddedetizacao.setCodigo(rs.getInt("codigo"));
                ddedetizacao.setCondominio(rs.getInt("condominio"));
                ddedetizacao.setEmpresa_resp(rs.getString("empresa_resp"));
                ddedetizacao.setData_dede(rs.getString("data_dede"));  
                ddedetizacao.setDescricao(rs.getString("descricao"));
                dedetizacao.add(ddedetizacao);
            }

        } catch (SQLException ex) {
            Logger.getLogger(DedetizacaoDAO.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return dedetizacao;
    }
    
    public void update(Dedetizacao d) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_dedetizacao SET condominio = ?,empresa_resp = ?,data_dede = ?,descricao = ? WHERE codigo = ?");            
            stmt.setInt(1, d.getCondominio());
            stmt.setString(2, d.getEmpresa_resp());
            stmt.setString(3, d.getData_dede());
            stmt.setString(4, d.getDescricao());
            stmt.setInt(5, d.getCodigo());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public void delete(Dedetizacao d) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("DELETE FROM tb_dedetizacao WHERE codigo = ?");
            stmt.setInt(1, d.getCodigo());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Excluido com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao excluir: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
}
        
        
    

