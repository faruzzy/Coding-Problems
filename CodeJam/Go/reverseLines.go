package main

import (
	"bufio"
	"log"
	"os"
	"strings"
)

func main() {
	f, err := os.Open("small.in")
	if err != nil {
		log.Fatal(err)
	}

	scanner := bufio.NewScanner(f)

	lines := ""
	counter := 0
	for scanner.Scan() {
		if counter == 0 {
			counter++
			continue
		}
		counter++
		words := strings.Split(scanner.Text(), " ")
		for i := len(words) - 1; i >= 0; i-- {
			lines += words[i] + " "
		}
		lines += "\n"
	}

	nf, err := os.Create("output.txt")
	if err != nil {
		log.Fatal(err)
	}

	nf.WriteString(lines)
	nf.Close()

}
