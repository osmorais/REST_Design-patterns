/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.SexoDAO;
import dao.iface.IntSexoDAO;
import java.util.ArrayList;
import modelo.Sexo;

/**
 *
 * @author superalunocmc
 */
public class SrvcSexo {

    public static ArrayList<Sexo> listar() {
        ArrayList<Sexo> arrsexos = new ArrayList<Sexo>();
        IntSexoDAO objsexodao = new SexoDAO();

        arrsexos = objsexodao.listar();

        return arrsexos;
    }
}
