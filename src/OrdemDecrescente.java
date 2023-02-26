import java.util.Arrays;

public class OrdemDecrescente {

    public static void main(String[] args) {
        sortDesc(123456789);
        hello();
    }

    public static void hello(){
        System.out.println("Hello World");
    }

    public static int sortDesc(final int num) {
        char[] chars = ("" + num).toCharArray(); //recebimento dos numeros na função [123456789] e colocando eles num array
        char temp = ' ';//aqui eu dou um espaçamento nos numeros, antes estava assim [1,2,3,4,5,6,7,8,9] agora fica assim [1, 2, 3, 4, 5, 6, 7, 8, 9]

        for (int i = 0; i < chars.length; i++) { //entrando no primeiro loop assim [1, 2, 3, 4, 5, 6, 7, 8, 9]
            for (int j = 0; j < chars.length -1; j++) {
                if(chars[j] < chars[j + 1]) {
                    //ordenação dos numeros do maior para o menor
                    temp = chars[j];
                    chars[j] = chars[j + 1];
                    chars[ j + 1 ] = temp;
                    System.out.println(Arrays.toString(chars));
                }
            }
        }
        return 0;

    }
}
