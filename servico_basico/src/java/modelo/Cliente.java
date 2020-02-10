/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.ArrayList;

/**
 *
 * @author superalunocmc
 */
public class Cliente extends Pessoa {

    private String codigoCliente;
    
    private int fkPessoa;

    public Cliente() {
    }

    public Cliente(String codigoCliente, String nome, Sexo sexo,
            ArrayList<Endereco> enderecos, int id) {
        super(nome, sexo, enderecos, id);
        this.codigoCliente = codigoCliente;
    }

    public Cliente(String codigoCliente, int fkPessoa, String nome, Sexo sexo,
            ArrayList<Endereco> enderecos, int id) {
        super(nome, sexo, enderecos, id);
        this.codigoCliente = codigoCliente;
        this.fkPessoa = fkPessoa;
    }

    public String getCodigoCliente() {
        return codigoCliente;
    }

    public void setCodigoCliente(String codigoCliente) {
        this.codigoCliente = codigoCliente;
    }

    public int getFkPessoa() {
        return fkPessoa;
    }

    public void setFkPessoa(int fkPessoa) {
        this.fkPessoa = fkPessoa;
    }
}
