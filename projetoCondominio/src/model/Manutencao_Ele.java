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
public class Manutencao_Ele {
    private int codigo;
    private int condominio;
    private String data_Manu;
    private String elevador;
    private String empresa_respo;
    private String descr;

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

    public String getData_Manu() {
        return data_Manu;
    }

    public void setData_Manu(String data_Manu) {
        this.data_Manu = data_Manu;
    }

    public String getElevador() {
        return elevador;
    }

    public void setElevador(String elevador) {
        this.elevador = elevador;
    }

    public String getEmpresa_respo() {
        return empresa_respo;
    }

    public void setEmpresa_respo(String empresa_respo) {
        this.empresa_respo = empresa_respo;
    }

    public String getDescr() {
        return descr;
    }

    public void setDescr(String descr) {
        this.descr = descr;
    }
    
    
}
