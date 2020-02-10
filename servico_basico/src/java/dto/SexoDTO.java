/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dto;

import modelo.*;

/**
 *
 * @author superalunocmc
 */
public class SexoDTO extends ObjetoDTO {
    
    private String descricao;

    public SexoDTO() {
    }

    public SexoDTO(String descricao, int id) {
        super(id);
        this.descricao = descricao;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
    public static SexoDTO getDto(Sexo sexo){
        return new SexoDTO(
                sexo.getDescricao(),
                sexo.getId()
        );
    }
    
    public Sexo getObj(){
        return new Sexo(
                this.getDescricao(),
                this.getId()
        );
    }
}
