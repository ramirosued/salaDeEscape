static class Escape{

static string[] respuestaSalas;
static int estadoJuego=1;

private static void InicializarJuego(){
    respuestaSalas=new string[]{"check in","4310","14","hotel"};
}

public static int GetEstadoJuego(){
    return estadoJuego;
}
public static int ReiniciarEstadoJuego(){
    estadoJuego=1;
    return estadoJuego;
}

public static bool ResolverSala(int sala, string respuesta){
    InicializarJuego();
    bool correcto= false;
    if(respuesta == respuestaSalas[estadoJuego-1])
    {
    correcto=true;
    estadoJuego++;
    }

    return correcto;
}

}