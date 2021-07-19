/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author Familia Coelho
 */
public class Contas_Condominio {
    private int codigo;
    private int condominio;
    private double agua;
    private double energia;
    private double taxa_Manutencao;
    private double valor_Condominio;
    private String data_Contas;
    private double total;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public int getCondominio() {
        return condominio;
    }

    public void setCondominio(int condominio) {
        this.condominio = condominio;
    }

    public double getAgua() {
        return agua;
    }

    public void setAgua(double agua) {
        this.agua = agua;
    }

    public double getEnergia() {
        return energia;
    }

    public void setEnergia(double energia) {
        this.energia = energia;
    }

    public double getTaxa_Manutencao() {
        return taxa_Manutencao;
    }

    public void setTaxa_Manutencao(double taxa_Manutencao) {
        this.taxa_Manutencao = taxa_Manutencao;
    }

    public double getValor_Condominio() {
        return valor_Condominio;
    }

    public void setValor_Condominio(double valor_Condominio) {
        this.valor_Condominio = valor_Condominio;
    }

    public String getData_Contas() {
        return data_Contas;
    }

    public void setData_Contas(String data_Contas) {
        this.data_Contas = data_Contas;
    }
    
     public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }    
}
