/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recurso;

import com.google.gson.Gson;
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;
import dto.DepartamentoDTO;
import dto.EnderecoDTO;
import dto.FuncionarioDTO;
import dto.SexoDTO;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import modelo.Funcionario;
import servico.SrvcFuncionario;

/**
 * REST Web Service
 *
 * @author superalunocmc
 */
@Path("funcionario")
public class RecFuncionario {

    private final Gson objgson;
    private final XStream xstream;
    
    @Context
    private UriInfo context;

    public RecFuncionario() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }

    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("json")
    public String cadastrarFuncionarioJson(String conteudo) {
        
        FuncionarioDTO dto = objgson.fromJson(conteudo, FuncionarioDTO.class);
        Funcionario objeto = dto.getObj();
        SrvcFuncionario.cadastrar(objeto);
        dto = FuncionarioDTO.getDto(objeto);
        
        return objgson.toJson(dto);
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_XML)
    @Produces(MediaType.APPLICATION_XML)
    @Path("xml")
    public String cadastrarFuncionarioXml(String conteudo) {
        
        xstream.alias("Funcionario", FuncionarioDTO.class);
        xstream.alias("departamento", DepartamentoDTO.class);
        xstream.alias("sexo", SexoDTO.class);
        xstream.alias("Endereco", EnderecoDTO.class);
        
        FuncionarioDTO dto = (FuncionarioDTO) xstream.fromXML(conteudo);
        Funcionario objeto = dto.getObj();
        SrvcFuncionario.cadastrar(objeto);
        dto = FuncionarioDTO.getDto(objeto);
        
        return xstream.toXML(dto);
    }
}
