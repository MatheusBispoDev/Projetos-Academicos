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
public class Condominio {
    private int codigo;
    private int empresa;
    private String andar;
    private int salas;
    private int vagas_Estacionamento;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public int getEmpresa() {
        return empresa;
    }

    public void setEmpresa(int empresa) {
        this.empresa = empresa;
    }

    public String getAndar() {
        return andar;
    }

    public void setAndar(String andar) {
        this.andar = andar;
    }

    public int getSalas() {
        return salas;
    }

    public void setSalas(int salas) {
        this.salas = salas;
    }

    public int getVagas_Estacionamento() {
        return vagas_Estacionamento;
    }

    public void setVagas_Estacionamento(int vagas_Estacionamento) {
        this.vagas_Estacionamento = vagas_Estacionamento;
    }
}