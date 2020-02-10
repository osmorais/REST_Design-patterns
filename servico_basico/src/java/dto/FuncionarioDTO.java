/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dto;

import java.util.ArrayList;
import modelo.Endereco;
import modelo.Funcionario;

/**
 *
 * @author superalunocmc
 */
public class FuncionarioDTO extends PessoaDTO {

    private DepartamentoDTO departamento;

    public FuncionarioDTO() {
    }

    public FuncionarioDTO(DepartamentoDTO departamento, String nome,
            SexoDTO sexo, ArrayList<EnderecoDTO> enderecos, int id) {
        super(nome, sexo, enderecos, id);
        this.departamento = departamento;
    }

    public DepartamentoDTO getDepartamento() {
        return departamento;
    }

    public void setDepartamento(DepartamentoDTO departamento) {
        this.departamento = departamento;
    }
    
    public static FuncionarioDTO getDto(Funcionario funcionario){
        ArrayList<EnderecoDTO> arrenderecoDto = new ArrayList<>();
        funcionario.getEnderecos().stream().map(
                (objeto) -> EnderecoDTO.getDto(objeto)
        ).forEachOrdered((dto) -> {
            arrenderecoDto.add(dto);
        });
        
        return new FuncionarioDTO(
                DepartamentoDTO.getDto(funcionario.getDepartamento()),
                funcionario.getNome(),
                SexoDTO.getDto(funcionario.getSexo()),
                arrenderecoDto,
                funcionario.getId()
        );
    }
    
    public Funcionario getObj(){
        ArrayList<Endereco> arrendereco = new ArrayList<>();
        this.getEnderecos().stream().map(
                (dto) -> dto.getObj()
        ).forEachOrdered((objeto) -> {
            arrendereco.add(objeto);
        });
        
        return new Funcionario(
                this.getDepartamento().getObj(),
                this.getNome(),
                this.getSexo().getObj(),
                arrendereco,
                this.getId()
        );
    }
}
