/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dto;

import java.util.ArrayList;

/**
 *
 * @author superalunocmc
 */
public abstract class PessoaDTO extends ObjetoDTO{
    private String nome;
    private SexoDTO sexo;
    private ArrayList<EnderecoDTO> enderecos;

    public PessoaDTO() {
    }

    public PessoaDTO(String nome, SexoDTO sexo, ArrayList<EnderecoDTO> enderecos, int id) {
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

    public SexoDTO getSexo() {
        return sexo;
    }

    public void setSexo(SexoDTO sexo) {
        this.sexo = sexo;
    }

    public ArrayList<EnderecoDTO> getEnderecos() {
        return enderecos;
    }

    public void setEnderecos(ArrayList<EnderecoDTO> enderecos) {
        this.enderecos = enderecos;
    }
}
