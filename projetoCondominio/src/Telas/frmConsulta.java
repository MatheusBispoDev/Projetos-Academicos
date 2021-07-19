/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Telas;

import factory.ConnectionFactory;
import java.awt.Color;
import java.sql.*;
import java.sql.Connection;
import java.sql.ResultSet;
import java.awt.Image;
import java.awt.Point;
import java.io.File;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import javax.swing.filechooser.FileNameExtensionFilter;
import net.proteanit.sql.DbUtils;

/**
 *
 * @author Michael
 */
public class frmConsulta extends javax.swing.JFrame {

    /**
     * Creates new form frmConsulta
     */
    public frmConsulta(String nivel) {
        initComponents();
        txtImg.setVisible(false);
        lblImg.setVisible(false);
        lblPesquisa.setVisible(false);
        txtPesquisa.setVisible(false);
        
        switch (nivel) {
            case "Locatários": 
                comboTabela.removeAllItems(); 
                comboTabela.addItem("Funcionarios");
                comboTabela.addItem("Materiais");
                comboTabela.addItem("Recepcao");
                comboTabela.addItem("Visitantes");                
                break;                
            case "Locadores": 
                comboTabela.removeAllItems();
                comboTabela.addItem("Empresa");
                comboTabela.addItem("Dedetizacao");                
                comboTabela.addItem("Historico de Contas");
                comboTabela.addItem("Manutencao dos elevadores"); 
                comboTabela.addItem("Condominios");    
                break;
        }
    }

    private frmConsulta() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    private void sqlPesquisar() {            
        String selecionado = (String)comboTabela.getSelectedItem();
        // conexão
        Connection conexao;
        // instrucao SQL
        PreparedStatement pst;
        // resultados
        ResultSet resultados;
        
        if("Empresa".equals(selecionado)){
            String sql = "SELECT * FROM tb_empresa WHERE nome_Fantasia like ?";
            try {
                lblPesquisa.setText("Nome Fantasia:");
                lblImg.setVisible(false);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
                
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar a empresa.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        else if("Dedetizacao".equals(selecionado)){
            String sql = "SELECT * FROM tb_dedetizacao WHERE condominio like ?";
            try {
                lblPesquisa.setText("Codigo do condominio:");
                lblImg.setVisible(false);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
                
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));          
            
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar as dedetizacoes.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        else if("Funcionarios".equals(selecionado)){
            String sql = "SELECT * FROM tb_funcionario WHERE nome like ?";
            try {
                txtImg.setText("");
                lblImg.setText("Imagem");
                lblImg.setIcon(null);
        
                lblPesquisa.setText("Nome:");
                lblImg.setVisible(true);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
               
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar os funcionarios.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        else if("Historico de Contas".equals(selecionado)){
            String sql = "SELECT * FROM tb_contas_condominio WHERE condominio like ?";
            try {
                lblPesquisa.setText("Codigo do condominio:");
                lblImg.setVisible(false);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
               
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro a consultas as contas.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        else if("Manutencao dos elevadores".equals(selecionado)){
            String sql = "SELECT * FROM tb_manutencao_ele WHERE condominio like ?";
            try {
                lblPesquisa.setText("Código do condominio:");
                lblImg.setVisible(false);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
               
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro a consulta as manutencoes dos elevadores.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        else if("Materiais".equals(selecionado)){
            String sql = "SELECT * FROM tb_materiais WHERE nome like ?";
            try {
                txtImg.setText("");
                lblImg.setText("Imagem");
                lblImg.setIcon(null);
        
                lblPesquisa.setText("Nome do material:");
                lblImg.setVisible(true);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
                
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar as manutencoes dos elevadores.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        else if("Recepcao".equals(selecionado)){
            String sql = "SELECT * FROM tb_recepcao WHERE dia like ?";
            try {
                lblPesquisa.setText("Dia da visita:");
                lblImg.setVisible(false);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
                
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar a recepcao.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        else if("Visitantes".equals(selecionado)){
            String sql = "SELECT * FROM tb_visitante WHERE nome like ?";
            try {
                txtImg.setText("");
                lblImg.setText("Imagem");
                lblImg.setIcon(null);
            
                lblPesquisa.setText("Nome do visitante:");
                lblImg.setVisible(true);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
                
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar a recepcao.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        else if("Condominios".equals(selecionado)){
            String sql = "SELECT * FROM tb_condominio WHERE codigo like ?";
            try {
                txtImg.setText("");
                lblImg.setText("Imagem");
                lblImg.setIcon(null);
            
                lblPesquisa.setText("Codigo do condominio:");
                lblImg.setVisible(false);
                lblPesquisa.setVisible(true);
                txtPesquisa.setVisible(true);
                
                // conectando ao banco de dados
                conexao = DriverManager.getConnection(ConnectionFactory.URL, ConnectionFactory.USER, ConnectionFactory.PASS);
            
                // criando a instrução SQL 
                pst = conexao.prepareStatement(sql);
                pst.setString(1,txtPesquisa.getText() + "%");
                resultados = pst.executeQuery();
                tblCon.setModel(DbUtils.resultSetToTableModel(resultados));
            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "Ocorreu um erro ao consultar a recepcao.");
                Logger.getLogger(frmCadFuncionarios.class.getName()).log(Level.SEVERE, null, ex);
            }    
            }
        
    }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel3 = new javax.swing.JPanel();
        lblPesquisa = new javax.swing.JLabel();
        txtPesquisa = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblCon = new javax.swing.JTable();
        jLabel3 = new javax.swing.JLabel();
        comboTabela = new javax.swing.JComboBox<String>();
        lblImg = new javax.swing.JLabel();
        txtImg = new javax.swing.JTextField();
        jPanel2 = new javax.swing.JPanel();
        btnSair = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        lblUsuário = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel3.setBackground(new java.awt.Color(255, 255, 255));
        jPanel3.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        lblPesquisa.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        lblPesquisa.setText("Código da Condominio:");

        txtPesquisa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtPesquisaActionPerformed(evt);
            }
        });
        txtPesquisa.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtPesquisaKeyReleased(evt);
            }
        });

        tblCon.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        tblCon.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        tblCon.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tblCon.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblConMouseClicked(evt);
            }
        });
        tblCon.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                tblConKeyReleased(evt);
            }
        });
        jScrollPane1.setViewportView(tblCon);

        jLabel3.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        jLabel3.setText("Selecione a tabela para realizar a pesquisa:");

        comboTabela.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        comboTabela.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Empresa", "Dedetizacao", "Funcionarios", "Historico de Contas", "Manutencao dos elevadores", "Materiais", "Recepcao", "Visitantes", "Condominios" }));
        comboTabela.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                comboTabelaActionPerformed(evt);
            }
        });

        lblImg.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        lblImg.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblImg.setText("Imagem");
        lblImg.setToolTipText("");
        lblImg.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        lblImg.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        lblImg.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        lblImg.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                lblImgMouseClicked(evt);
            }
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                lblImgMouseEntered(evt);
            }
        });

        txtImg.setEditable(false);
        txtImg.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        txtImg.setText("Caminho da img");
        txtImg.setEnabled(false);
        txtImg.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtImgActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(48, 48, 48)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addGap(30, 30, 30)
                        .addComponent(comboTabela, javax.swing.GroupLayout.PREFERRED_SIZE, 429, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(lblImg, javax.swing.GroupLayout.PREFERRED_SIZE, 142, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtImg, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(27, 27, 27)
                        .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel3Layout.createSequentialGroup()
                                .addComponent(lblPesquisa)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(txtPesquisa))
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 764, Short.MAX_VALUE))))
                .addContainerGap())
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(25, 25, 25)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(comboTabela, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addGap(42, 42, 42)
                        .addComponent(lblImg, javax.swing.GroupLayout.PREFERRED_SIZE, 142, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(txtImg, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 156, Short.MAX_VALUE))
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(txtPesquisa, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblPesquisa))
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );

        jPanel2.setBackground(new java.awt.Color(54, 33, 89));
        jPanel2.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        btnSair.setBackground(new java.awt.Color(217, 81, 51));
        btnSair.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        btnSair.setText("Sair");
        btnSair.setBorderPainted(false);
        btnSair.setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));
        btnSair.setFocusPainted(false);
        btnSair.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                btnSairMouseEntered(evt);
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                btnSairMouseExited(evt);
            }
        });
        btnSair.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSairActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(btnSair, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap(16, Short.MAX_VALUE)
                .addComponent(btnSair, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        jPanel1.setBackground(new java.awt.Color(54, 33, 89));
        jPanel1.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        lblUsuário.setFont(new java.awt.Font("Segoe UI", 1, 24)); // NOI18N
        lblUsuário.setForeground(new java.awt.Color(255, 255, 255));
        lblUsuário.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblUsuário.setText("Consulta");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblUsuário, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(lblUsuário, javax.swing.GroupLayout.PREFERRED_SIZE, 69, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void txtPesquisaKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPesquisaKeyReleased
            sqlPesquisar();
    }//GEN-LAST:event_txtPesquisaKeyReleased

    private void btnSairMouseEntered(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnSairMouseEntered
        btnSair.setBackground(new Color(235, 235, 235));
        btnSair .setForeground(new Color(217, 81, 51));
    }//GEN-LAST:event_btnSairMouseEntered

    private void btnSairMouseExited(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnSairMouseExited
        btnSair.setBackground(new Color(217, 81, 51));
        btnSair.setForeground(Color.WHITE);
    }//GEN-LAST:event_btnSairMouseExited

    private void btnSairActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSairActionPerformed
        this.dispose();
    }//GEN-LAST:event_btnSairActionPerformed

    private void comboTabelaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_comboTabelaActionPerformed
        sqlPesquisar();
    }//GEN-LAST:event_comboTabelaActionPerformed

    private void lblImgMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_lblImgMouseClicked
        JFileChooser filechooser = new JFileChooser();
        FileNameExtensionFilter filter = new FileNameExtensionFilter("Imagem", "jpg", "jpge", "png");
        Point point = new Point();
        point = lblImg.getLocation();
        filechooser.setFileFilter(filter);
        filechooser.setDialogTitle("Procurar Imagem");
        filechooser.setMultiSelectionEnabled(false);
        int retorno = filechooser.showOpenDialog(this);

        if(retorno == JFileChooser.APPROVE_OPTION){
            Image img = new ImageIcon(filechooser.getSelectedFile().getAbsolutePath()).getImage().getScaledInstance(140, 140, Image.SCALE_DEFAULT);
            File file = filechooser.getSelectedFile();
            txtImg.setText(file.getPath());
            lblImg.setText("");
            lblImg.setIcon(new ImageIcon(img));
            lblImg.setLocation(point);
            point = tblCon.getLocation();
            tblCon.setLocation(point);
        }
    }//GEN-LAST:event_lblImgMouseClicked

    private void lblImgMouseEntered(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_lblImgMouseEntered

    }//GEN-LAST:event_lblImgMouseEntered

    private void txtImgActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtImgActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtImgActionPerformed

    private void tblConMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblConMouseClicked
        if (tblCon.getSelectedRow() != -1) {
            JFileChooser filechooser = new JFileChooser();
            if ("Funcionarios".equals(comboTabela.getSelectedItem().toString())){
                txtImg.setText(tblCon.getValueAt(tblCon.getSelectedRow(), 7).toString()); 
            }
            else if ("Materiais".equals(comboTabela.getSelectedItem().toString())){
                txtImg.setText(tblCon.getValueAt(tblCon.getSelectedRow(), 4).toString()); 
            }
            else if ("Visitantes".equals(comboTabela.getSelectedItem().toString())){
                txtImg.setText(tblCon.getValueAt(tblCon.getSelectedRow(), 6).toString()); 
            }              
                    
            ImageIcon img = new ImageIcon(new ImageIcon(txtImg.getText()).getImage().getScaledInstance(150, 150, Image.SCALE_DEFAULT));
            lblImg.setIcon(img);            
            lblImg.setText("");         
        } 
    }//GEN-LAST:event_tblConMouseClicked

    private void tblConKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_tblConKeyReleased
       if (tblCon.getSelectedRow() != -1) {
           JFileChooser filechooser = new JFileChooser();
            
            txtImg.setText(tblCon.getValueAt(tblCon.getSelectedRow(), 4).toString());        
            
            ImageIcon img = new ImageIcon(new ImageIcon(txtImg.getText()).getImage().getScaledInstance(140, 140, Image.SCALE_DEFAULT));
            lblImg.setIcon(img);
            
            lblImg.setText("");           
        } 
    }//GEN-LAST:event_tblConKeyReleased

    private void txtPesquisaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtPesquisaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtPesquisaActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(frmConsulta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmConsulta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmConsulta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmConsulta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frmConsulta().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnSair;
    private javax.swing.JComboBox<String> comboTabela;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblImg;
    private javax.swing.JLabel lblPesquisa;
    private javax.swing.JLabel lblUsuário;
    private javax.swing.JTable tblCon;
    private javax.swing.JTextField txtImg;
    private javax.swing.JTextField txtPesquisa;
    // End of variables declaration//GEN-END:variables
}
