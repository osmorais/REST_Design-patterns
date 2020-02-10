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
public class Funcionario extends Pessoa {

    private Departamento departamento;
    
    private int fkPessoa;

    public Funcionario() {
    }

    public Funcionario(Departamento departamento, String nome, Sexo sexo,
            ArrayList<Endereco> enderecos, int id) {
        super(nome, sexo, enderecos, id);
        this.departamento = departamento;
    }

    public Funcionario(Departamento departamento, int fkPessoa, String nome,
            Sexo sexo, ArrayList<Endereco> enderecos, int id) {
        super(nome, sexo, enderecos, id);
        this.departamento = departamento;
        this.fkPessoa = fkPessoa;
    }

    public Departamento getDepartamento() {
        return departamento;
    }

    public void setDepartamento(Departamento departamento) {
        this.departamento = departamento;
    }

    public int getFkPessoa() {
        return fkPessoa;
    }

    public void setFkPessoa(int fkPessoa) {
        this.fkPessoa = fkPessoa;
    }
}
