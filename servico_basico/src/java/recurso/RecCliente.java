/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recurso;

import com.google.gson.Gson;
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;
import dto.ClienteDTO;
import dto.EnderecoDTO;
import dto.SexoDTO;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Consumes;
import javax.ws.rs.Path;
import javax.ws.rs.POST;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import modelo.Cliente;
import servico.SrvcCliente;

/**
 * REST Web Service
 *
 * @author superalunocmc
 */
@Path("cliente")
public class RecCliente {

    private final Gson objgson;
    private final XStream xstream;
    
    @Context
    private UriInfo context;

    public RecCliente() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }

    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("json")
    public String cadastrarClienteJson(String conteudo) {

        ClienteDTO dto = objgson.fromJson(conteudo, ClienteDTO.class);
        Cliente objeto = dto.getObj();
        SrvcCliente.cadastrar(objeto);
        dto = ClienteDTO.getDto(objeto);
        
        return objgson.toJson(dto);
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_XML)
    @Produces(MediaType.APPLICATION_XML)
    @Path("xml")
    public String cadastrarClienteXml(String conteudo) {
        
        xstream.alias("Cliente", ClienteDTO.class);
        xstream.alias("sexo", SexoDTO.class);
        xstream.alias("Endereco", EnderecoDTO.class);
        
        ClienteDTO dto = (ClienteDTO) xstream.fromXML(conteudo);
        Cliente objeto = dto.getObj();
        SrvcCliente.cadastrar(objeto);
        dto = ClienteDTO.getDto(objeto);
        
        return xstream.toXML(dto);
    }
}
