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
public class Empresa {
    private int codigo;   
    private String locador;    
    private String nome_Fantasia;
    private String razao_Social;
    private String cnpj;
    
    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
      
    public String getLocador() {
        return locador;
    }

    public void setLocador(String locador) {
        this.locador = locador;
    }   

    public String getNome_Fantasia() {
        return nome_Fantasia;
    }

    public void setNome_Fantasia(String nome_Fantasia) {
        this.nome_Fantasia = nome_Fantasia;
    }

    public String getRazao_Social() {
        return razao_Social;
    }

    public void setRazao_Social(String razao_Social) {
        this.razao_Social = razao_Social;
    }

    public String getCnpj() {
        return cnpj;
    }

    public void setCnpj(String cnpj) {
        this.cnpj = cnpj;
    }   

        @Override
        public String toString() {
            return nome_Fantasia;
        }
}