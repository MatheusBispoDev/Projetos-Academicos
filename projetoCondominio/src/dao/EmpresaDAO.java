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
import model.Empresa;

/**
 *
 * @author Familia Coelho
 */
public class EmpresaDAO {
    public void create(Empresa e) {
        Connection con = ConnectionFactory.getConnection();
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("INSERT INTO tb_empresa (codigo,locador,"
                    + "nome_Fantasia,razao_Social,cnpj)VALUES(?,?,?,?,?)");
            stmt.setInt(1, e.getCodigo());
            stmt.setString(2, e.getLocador());            
            stmt.setString(3, e.getNome_Fantasia());
            stmt.setString(4, e.getRazao_Social());
            stmt.setString(5, e.getCnpj());

            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Salvo com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            System.out.println(ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
    
    public List<Empresa> read() {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;
        ResultSet rs = null;

        List<Empresa> empresas = new ArrayList<>();

        try {
            stmt = con.prepareStatement("SELECT * FROM tb_empresa");
            rs = stmt.executeQuery();

            while (rs.next()) {

                Empresa empresa = new Empresa();

                empresa.setCodigo(rs.getInt("codigo"));
                empresa.setLocador(rs.getString("locador"));                
                empresa.setNome_Fantasia(rs.getString("nome_Fantasia")); 
                empresa.setRazao_Social(rs.getString("razao_Social"));  
                empresa.setCnpj(rs.getString("cnpj"));  
                empresas.add(empresa);
            }
        } catch (SQLException ex) {
            Logger.getLogger(Empresa.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt, rs);
        }
        return empresas;
    }
    
    public void update(Empresa e) {
        Connection con = ConnectionFactory.getConnection();
        
        PreparedStatement stmt = null;

        try {
            stmt = con.prepareStatement("UPDATE tb_empresa SET locador = ?, nome_Fantasia = ?, razao_Social = ?,"
                    + "cnpj = ? WHERE codigo = ?");            
            
            stmt.setString(1, e.getLocador());            
            stmt.setString(2, e.getNome_Fantasia());
            stmt.setString(3, e.getRazao_Social());
            stmt.setString(4, e.getCnpj());
            stmt.setInt(5, e.getCodigo());
            stmt.executeUpdate();

            JOptionPane.showMessageDialog(null, "Atualizado com sucesso!", "Sucesso", JOptionPane.INFORMATION_MESSAGE);
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao atualizar: " + ex);
        } finally {
            ConnectionFactory.closeConnection(con, stmt);
        }
    }
}
