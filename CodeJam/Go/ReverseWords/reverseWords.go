package main

import (
	"bufio"
	"log"
	"os"
	"strconv"
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
		words := strings.Split(scanner.Text(), " ")

		lines += "Case #" + strconv.Itoa(counter) + ": "
		for i := len(words) - 1; i >= 0; i-- {
			lines += words[i] + " "
		}
		lines += "\n"
		counter++
	}

	nf, err := os.Create("output.txt")
	if err != nil {
		log.Fatal(err)
	}

	nf.WriteString(lines)
	nf.Close()

}
