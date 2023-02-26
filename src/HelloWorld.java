public class HelloWorld {
    public static void main(String[] args) {
        System.out.println(greet());
    }

    public static String greet() {
        return "hello world!";
    }
}

/*
* import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class HelloWorldTest {
  @Test
  public void testHelloWorld() throws Exception {
    assertEquals("hello world!", HelloWorld.greet());
  }
}
* */