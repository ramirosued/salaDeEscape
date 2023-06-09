static class Escape{

static string[] respuestaSalas;
static int estadoJuego=0;

private static void InicializarJuego(){
    respuestaSalas=new string[]{"check in","4310","14","hotel"};
}

public static int GetEstadoJuego(){
    return estadoJuego;
}

public static bool ResolverSala(int sala, string respuesta){
    InicializarJuego();
    bool correcto= false;
    if(respuesta == respuestaSalas[estadoJuego])
    {
    correcto=true;
    estadoJuego++;
    }

    return correcto;
}

}