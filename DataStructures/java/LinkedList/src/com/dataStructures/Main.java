package com.dataStructures;

public class Main {

    public static void main(String[] args) {
        final LinkedList<String> list = new LinkedList<String>();

        list.append("hello");
        list.append("there");
        list.prepend("Roland");

        System.out.println(list);

        list.removeAtHead();

        System.out.println(list);

        list.prepend("Soraya");
        list.prepend("Nicholas");
        list.append("Ninja");

        System.out.println(list);
        System.out.printf("Length is %d \n", list.getLength());

        list.removeAtTail();
        System.out.println(list);
        System.out.println(list.get(2));
        list.insert(2, "bye");
        System.out.println(list);
        System.out.println(list);
    }
}
