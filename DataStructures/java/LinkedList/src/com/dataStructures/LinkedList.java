package com.dataStructures;

/**
 * Created by faruzzy on 9/26/15.
 */
public class LinkedList<T> {
    private Node<T> head, tail;
    private int length;

    public LinkedList() {
        head = tail = null;
        length = 0;
    }

    public void append(final T value) {
        final Node<T> node = new Node<T>(value);
        if (isEmpty())
            head = tail = node;

        tail.setNext(node);
        tail = node;
        length++;
    }

    public void prepend(final T value) {
        final Node<T> node = new Node<T>(value);
        if (isEmpty())
            head = tail = node;

        node.setNext(head);
        head = node;
        length++;
    }

    public void removeAtHead() {
        checkEmpty();

        if (length == 1)
            clear();

        head = head.getNext();
        length--;
    }

    public void removeAtTail() {
        checkEmpty();

        if (length == 1)
            clear();

        Node<T> curr = head;
        while (curr.getNext() != tail)
            curr = curr.getNext();

        tail = curr;
        tail.setNext(null);
        length--;
    }

    public void insert(final int index, final T value) {
        checkEmpty();

        if (index == 0) {
            prepend(value);
        } else {
            int counter = 0;
            Node<T> node = new Node<T>(value);
            Node<T> curr = head;
            while (counter++ < index)
                curr = curr.getNext();

            Node<T> nextNode = curr.getNext().getNext();
            curr.setNext(node);
            node.setNext(nextNode);
        }
    }

    public T get(final int index) {
        checkEmpty();
        if (index == 0)
            return head.getValue();

        int counter = 0;
        Node<T> curr = head;
        while (counter++ != index)
            curr = curr.getNext();

        return curr.getValue();
    }

    private void checkEmpty() {
        if (isEmpty())
            throw new EmptyLinkedListException("Linked List is Empty");
    }

    public boolean isEmpty() {
        return length == 0;
    }

    public void clear() {
        head = tail = null;
        length = 0;
    }

    public int getLength() {
        return length;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("[");
        if (isEmpty())
            return sb.append(" ]").toString();

        sb.append(head.getValue());
        Node<T> curr = head.getNext();
        while(curr != null) {
            sb.append(" ,");
            sb.append(curr.getValue());
            curr = curr.getNext();
        }
        return sb.append(" ]").toString();
    }
}
