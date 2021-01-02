import { Component } from "@angular/core"
import { Usuario } from "../../modelo/usuario";


@Component({
  selector: "app-login"
  , templateUrl: "./login.component.html"
  , styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public usuario;
  public usuarioAutenticado: boolean;
  public usuarios: ["usuario1", "usuario2", "usuario3", "usuario4", "usuario5"];

  constructor() {
    this.usuario = new Usuario();
    this.usuario.email = "paulo@paulo.com";
    this.usuario.senha = "";
    this.usuarioAutenticado = false;
    
    this.usuarios = ["usuario1", "usuario2", "usuario3", "usuario4", "usuario5"];
  }

  public tituloImagem = "Titulo adicionado no componente";
  public urlImagem = "https://www.einerd.com.br/wp-content/uploads/2019/09/One-Piece-capa-890x466.png";

  entrar(): void {
    this.usuarioAutenticado = this.usuario.email == "1" && this.usuario.senha == "a";
  }
}
