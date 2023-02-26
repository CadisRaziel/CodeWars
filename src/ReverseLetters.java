public class ReverseLetters {
    public static void main(String[] args) {


        /*

        //Aqui todas as 'letras são revertidas'

        String stringExample = "The greatest victory is that which requires no battle";

        System.out.println("Original string : " + stringExample);

        //Declarando um StringBuilder e convertendo string em StringBuilder
        StringBuilder reverseString = new StringBuilder(stringExample);

        //Invertendo o StringBuilder
        reverseString.reverse();


        // Convertendo StringBuilder para String
        String result = reverseString.toString();

        System.out.println(result);

         */

        String result = solution("world");
        System.out.println(result);
    }
    public static String solution(String str) {
        StringBuilder reverseString = new StringBuilder(str);
        return reverseString.reverse().toString();

    }

}

