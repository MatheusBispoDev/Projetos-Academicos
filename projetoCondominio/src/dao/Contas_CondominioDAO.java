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
import model.Contas_Condominio;

/**
 *
 * @author Familia Coelho
 */
public class Contas_CondominioDAO {
    public void create(Contas_Condominio cc) {
        Connection con = ConnectionFactory.getConnection();
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_contas_condominio (codigo,condominio,consumo_agua,consumo_energia,"
                    + "taxa_manutencao,valor_condominio,data_contas,total) VALUES(?,?,?,?,?,?,?,?)");
            
            stmt.setInt(1, cc.getCodigo());
            stmt.setInt(2, cc.getCondominio());
            stmt.setDouble(3, cc.getAgua());
            stmt.setDouble(4, cc.getEnergia());
            stmt.setDouble(5, cc.getTaxa_Manutencao());
            stmt.setDouble(6, cc.getValor_Condominio());
            stmt.setString(7, cc.getData_Contas());
            stmt.setDouble(8, cc.getTotal());
            
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Contas_Condominio> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Contas_Condominio> ccs = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_contas_condominio");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Contas_Condominio cc = new Contas_Condominio();

                cc.setCodigo(rs.getInt("codigo"));
                cc.setCondominio(rs.getInt("condominio"));
                cc.setAgua(rs.getDouble("consumo_agua"));  
                cc.setEnergia(rs.getDouble("consumo_energia"));
                cc.setTaxa_Manutencao(rs.getDouble("taxa_manutencao"));
                cc.setValor_Condominio(rs.getDouble("valor_condominio"));
                cc.setData_Contas(rs.getString("data_contas"));
                cc.setTotal(rs.getDouble("total"));
                
                ccs.add(cc);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Contas_Condominio.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return ccs;
    }
    
     public void update(Contas_Condominio cc) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_contas_condominio SET condominio = ?, consumo_agua = ?, consumo_energia = ?,"
                    + "taxa_manutencao = ?, valor_condominio = ?, data_contas = ?, total = ? WHERE codigo = ?");            
            
            stmt.setInt(1, cc.getCondominio());
            stmt.setDouble(2, cc.getAgua());
            stmt.setDouble(3, cc.getEnergia());
            stmt.setDouble(4, cc.getTaxa_Manutencao());
            stmt.setDouble(5, cc.getValor_Condominio());
            stmt.setString(6, cc.getData_Contas());
            stmt.setDouble(7, cc.getTotal());
            stmt.setInt(8, cc.getCodigo());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
}
