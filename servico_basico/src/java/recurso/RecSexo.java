/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recurso;

import com.google.gson.Gson;
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;
import dto.SexoDTO;
import java.util.ArrayList;
import javax.ws.rs.Produces;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.UriInfo;
import modelo.Sexo;
import servico.SrvcSexo;

/**
 * REST Web Service
 *
 * @author superalunocmc
 */
@Path("sexo")
public class RecSexo {

    private final Gson objgson;
    private final XStream xstream;
    
    @Context
    private UriInfo context;

    public RecSexo() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    @Path("json")
    public String listarJson() {
        
        ArrayList<SexoDTO> arrdto = new ArrayList<>();
        
        SrvcSexo.listar().stream().map(
                (objeto) -> SexoDTO.getDto(objeto)
        ).forEachOrdered((dto) -> {
            arrdto.add(dto);
        });
        
        String retorno = objgson.toJson(arrdto);
        
        return retorno;
    }
    
    @GET
    @Produces(MediaType.APPLICATION_XML)
    @Path("xml")
    public String listarXml() {
        
        xstream.alias("Sexo", SexoDTO.class);
        ArrayList<SexoDTO> arrdto = new ArrayList<>();
        
        SrvcSexo.listar().stream().map(
                (objeto) -> SexoDTO.getDto(objeto)
        ).forEachOrdered((dto) -> {
            arrdto.add(dto);
        });
        
        String retorno = xstream.toXML(arrdto);
        
        return retorno;
    }
}
