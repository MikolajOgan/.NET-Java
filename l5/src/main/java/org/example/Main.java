package org.example;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Problem p1 = new Problem(1, 10, 10, 123);
        p1.print_items();
        System.out.println(p1.solve(10).toString());
    }
}