package com.dataStructures;

/**
 * Created by faruzzy on 9/26/15.
 */
public class DLinkedList<T> {
    private DNode<T> header, trailer;
    private int length;

    public DLinkedList() {
        header = new DNode<T>(null, null, null);
        trailer = new DNode<T>(null, header, null);
        header.setNext(trailer);
        length = 0;
    }

    public void append(final T value) {
        DNode<T> node = new DNode<T>(value, null, null);

        DNode<T> prev = trailer.getPrev();
        trailer.setPrev(node);
        node.setNext(trailer);

        prev.setNext(node);
        node.setPrev(prev);

        length++;
    }

    public void prepend(final T value) {
        DNode<T> node = new DNode<T>(value, null, null);
        header.setNext(node);
        node.setPrev(header);
        length++;
    }

    private void checkEmpty() {
        if (isEmpty())
            throw new EmptyLinkedListException("Linked List is Empty");
    }

    public boolean isEmpty() {
        return length == 0;
    }

    public int getLength() {
        return length;
    }


}
