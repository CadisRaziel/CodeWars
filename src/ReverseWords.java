import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class ReverseWords {

    public static void main(String[] args) {
        System.out.println(reverseWords("The greatest victory is that which requires no battle"));
        System.out.println(reverseWords2("The greatest victory is that which requires no battle"));
       }

    public static String reverseWords(String str) {
        String[] words = str.split(" "); //aqui eu recebo a string "The greatest victory is that which requires no battle"
        StringBuilder result = new StringBuilder(words.length); //aqui ela é transformada em um array de palavras(com o nosso split ali de cima words: ["The", "greatest", "victory", "is", "that", "whitch", "requires", "no", "battle"]
        for (int i = words.length - 1; i >= 0; i--) {// aqui fara o loop 9 vezes para cada palavra do array
            if(words[i].length() != 0){
                if(result.length() != 0){
                    result.append(" ");
                }
                result.append(words[i]); //aqui ele começa a inverte a frase, o append vai incluindo as palavras ao final da frase
                //no for ele ta pegando palavra por palavra do arry, e no result.append ele ta colocando essas palavras
                //como no loop ta -1 e i--, ele ta pegando a ultima e colocando primeiro
            }
        }
        return result.toString();//e aqui retorna o stringBuilder como string
    }

    //outra maneira mais simples
    public static String reverseWords2(String str) {
        List<String> words = Arrays.asList(str.split(" "));
        Collections.reverse(words);
        return String.join(" ", words);
    }


}
