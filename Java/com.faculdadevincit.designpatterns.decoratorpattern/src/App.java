public class App {
    public static void main(String[] args) throws Exception {
        ICafe cafe = new CafeSimples();
        System.out.println(cafe.getDescricao() + " Preço: " + cafe.getCusto());

        cafe = new CafeAdicionalDeLeite(cafe);
        System.out.println(cafe.getDescricao() + " Preço: " + cafe.getCusto());

        cafe = new CafeAdicionalDeAcucar(cafe);
        System.out.println(cafe.getDescricao() + " Preço: " + cafe.getCusto());
    }
}
