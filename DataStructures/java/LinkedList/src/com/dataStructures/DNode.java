package com.dataStructures;

/**
 * Created by faruzzy on 9/26/15.
 */
public class DNode<T> {
    private DNode<T> prev, next;
    private T value;
    private int length;

    public DNode(final T value, final DNode<T> prev, final DNode<T> next) {
        this.value = value;
        this.prev = prev;
        this.next = next;
        length = 0;
    }

    public void setNext(final DNode<T> next) {
        this.next = next;
    }

    public DNode<T> getNext() {
        return next;
    }

    public void setPrev(final DNode<T> prev) {
        this.prev = prev;
    }

    public DNode<T> getPrev() {
        return prev;
    }

    public void setValue(final T value) {
        this.value = value;
    }

    public T getValue() {
        return value;
    }

    @Override
    public String toString() {
        return value.toString();
    }
}
