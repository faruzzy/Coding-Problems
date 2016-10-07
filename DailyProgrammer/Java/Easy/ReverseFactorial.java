/**
 * https://www.reddit.com/r/dailyprogrammer/comments/55nior/20161003_challenge_286_easy_reverse_factorial/
 */
public class ReverseFactorial {
	private static void reverse(int value) {
		int current = value;
		int i = 2;

		while (current % i == 0) {
			int result = current / i;
			if (result != 1) {
				i++;
				current = result;
			} else {
				System.out.printf("%d = %d\n", value, current);
				break;
			}
		}
		
		System.out.println("None");
	}

	public static void main(String[] args) {
		System.out.println();
		reverse(120);
		reverse(3628800);
		reverse(479001600);
		reverse(6);
		reverse(18);
	}
}
