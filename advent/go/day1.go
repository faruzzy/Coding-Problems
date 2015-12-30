package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strings"
)

func main() {
	f, err := os.Open("input.txt")
	defer f.Close()
	if err != nil {
		log.Fatal(err)
	}

	scanner := bufio.NewScanner(f)

	counter := 0
	for scanner.Scan() {
		line := scanner.Text()
		token := strings.Split(line, "")

		for _, v := range token {
			if v == "(" {
				counter++
			} else {
				counter--
			}
		}
	}

	fmt.Println(counter)
}
