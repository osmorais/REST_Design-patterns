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
public abstract class Pessoa extends Objeto{
    private String nome;
    private Sexo sexo;
    private ArrayList<Endereco> enderecos;

    public Pessoa() {
    }

    public Pessoa(String nome, Sexo sexo, ArrayList<Endereco> enderecos, int id) {
        super(id);
        this.nome = nome;
        this.sexo = sexo;
        this.enderecos = enderecos;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Sexo getSexo() {
        return sexo;
    }

    public void setSexo(Sexo sexo) {
        this.sexo = sexo;
    }

    public ArrayList<Endereco> getEnderecos() {
        return enderecos;
    }

    public void setEnderecos(ArrayList<Endereco> enderecos) {
        this.enderecos = enderecos;
    }
}
