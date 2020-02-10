/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dto;

import modelo.Departamento;

/**
 *
 * @author superalunocmc
 */
public class DepartamentoDTO extends ObjetoDTO {

    private String descricao;

    public DepartamentoDTO() {
    }

    public DepartamentoDTO(String descricao, int id) {
        super(id);
        this.descricao = descricao;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
    public static DepartamentoDTO getDto(Departamento departamento){
        return new DepartamentoDTO(
                departamento.getDescricao(),
                departamento.getId()
        );
    }
    
    public Departamento getObj(){
        return new Departamento(
                this.getDescricao(),
                this.getId()
        );
    }
}
