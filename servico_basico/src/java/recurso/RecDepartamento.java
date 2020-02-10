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
import java.util.ArrayList;
import javax.ws.rs.Consumes;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Produces;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.core.MediaType;
import modelo.Departamento;
import servico.SrvcDepartamento;

/**
 * REST Web Service
 *
 * @author superalunocmc
 */
@Path("departamento")
public class RecDepartamento {

    private final Gson objgson;
    private final XStream xstream;

    @Context
    private UriInfo context;

    public RecDepartamento() {
        this.objgson = new Gson();
        this.xstream = new XStream(new DomDriver());
    }
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    @Path("json")
    public String listarJson() {
        
        ArrayList<DepartamentoDTO> arrdto = new ArrayList<>();
        
        SrvcDepartamento.listar().stream().map(
                (departamento) -> new DepartamentoDTO(
                        departamento.getDescricao(),
                        departamento.getId()
        )).forEachOrdered((dto) -> {
            arrdto.add(dto);
        });
        
        String retorno = objgson.toJson(arrdto);
        
        return retorno;
    }
    
    @GET
    @Produces(MediaType.APPLICATION_XML)
    @Path("xml")
    public String listarXml() {
        
        xstream.alias("Departamento", DepartamentoDTO.class);
        ArrayList<DepartamentoDTO> arrdto = new ArrayList<>();
        
        SrvcDepartamento.listar().stream().map(
                (departamento) -> new DepartamentoDTO(
                        departamento.getDescricao(),
                        departamento.getId()
        )).forEachOrdered((dto) -> {
            arrdto.add(dto);
        });
        
        String retorno = xstream.toXML(arrdto);
        
        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("json")
    public String cadastrarJson(String conteudo) {
        
        DepartamentoDTO dto = objgson.fromJson(conteudo, DepartamentoDTO.class);
        Departamento objeto = dto.getObj();
        SrvcDepartamento.cadastrar(objeto);
        dto = DepartamentoDTO.getDto(objeto);
        
        String retorno = objgson.toJson(dto);

        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_XML)
    @Produces(MediaType.APPLICATION_XML)
    @Path("xml")
    public String cadastrarXml(String conteudo) {
        
        xstream.alias("Departamento", DepartamentoDTO.class);
        
        DepartamentoDTO dto = (DepartamentoDTO) xstream.fromXML(conteudo);
        Departamento objeto = dto.getObj();
        SrvcDepartamento.cadastrar(objeto);
        dto = DepartamentoDTO.getDto(objeto);
        
        String retorno = xstream.toXML(dto);

        return retorno;
    }
}
