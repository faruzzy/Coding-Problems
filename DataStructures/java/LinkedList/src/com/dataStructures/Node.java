package com.dataStructures;

/**
 * Created by faruzzy on 9/26/15.
 */
public class Node<T> {
    private Node<T> next;
    private final T value;

    public Node(final T value) {
        this.value = value;
        next = null;
    }

    public void setNext(Node<T> next) {
        this.next = next;
    }

    public Node<T> getNext() {
        return next;
    }

    public T getValue() {
        return value;
    }

    @Override
    public String toString() {
        return value.toString();
    }
}
