/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

/**
 *
 * @author superalunocmc
 */
public class Sexo extends Objeto {
    
    private String descricao;

    public Sexo() {
    }

    public Sexo(String descricao, int id) {
        super(id);
        this.descricao = descricao;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
}
