/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dto;

import java.util.ArrayList;
import modelo.Cliente;
import modelo.Endereco;

/**
 *
 * @author superalunocmc
 */
public class ClienteDTO extends PessoaDTO {

    private String codigoCliente;

    public ClienteDTO() {
    }

    public ClienteDTO(String codigoCliente, String nome, SexoDTO sexo,
            ArrayList<EnderecoDTO> enderecos, int id) {
        super(nome, sexo, enderecos, id);
        this.codigoCliente = codigoCliente;
    }

    public String getCodigoCliente() {
        return codigoCliente;
    }

    public void setCodigoCliente(String codigoCliente) {
        this.codigoCliente = codigoCliente;
    }
    
    public static ClienteDTO getDto(Cliente cliente){
        ArrayList<EnderecoDTO> arrenderecoDto = new ArrayList<>();
        cliente.getEnderecos().stream().map(
                (objeto) -> EnderecoDTO.getDto(objeto)
        ).forEachOrdered((dto) -> {
            arrenderecoDto.add(dto);
        });
        
        return new ClienteDTO(
                cliente.getCodigoCliente(),
                cliente.getNome(),
                SexoDTO.getDto(cliente.getSexo()),
                arrenderecoDto,
                cliente.getId()
        );
    }
    
    public Cliente getObj(){
        ArrayList<Endereco> arrendereco = new ArrayList<>();
        this.getEnderecos().stream().map(
                (dto) -> dto.getObj()
        ).forEachOrdered((objeto) -> {
            arrendereco.add(objeto);
        });
        
        return new Cliente(
                this.getCodigoCliente(),
                this.getNome(),
                this.getSexo().getObj(),
                arrendereco,
                this.getId()
        );
    }
}
