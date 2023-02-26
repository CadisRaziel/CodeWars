public class AprendendoAppend {
    public static void main(String[] args) {
        // um StringBuffer contendo uma frase
        StringBuffer frase = new StringBuffer("Gosto muito de programar");

// vamos adicionar mais duas palavras ao final do StringBuffer
        frase.append(" em");
        frase.append(" Java");
// agora mostramos o resultado
        System.out.println(frase);

        System.exit(0);
    }
}
