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
public class Dedetizacao {

    
    private int codigo;
    private int condominio;
    private String empresa_resp;
    private String data_dede;
    private String descricao;

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

    public String getEmpresa_resp() {
        return empresa_resp;
    }

    public void setEmpresa_resp(String empresa_resp) {
        this.empresa_resp = empresa_resp;
    }

    public String getData_dede() {
        return data_dede;
    }

    public void setData_dede(String data_dede) {
        this.data_dede = data_dede;
    }
    
    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descr) {
        this.descricao = descr;
    }
    
}
