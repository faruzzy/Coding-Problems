import java.io.IOException;
import java.util.List;
import java.util.ArrayList;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.charset.StandardCharsets;

public class IntermediateBlinkingLEDs {
	private static int[] registerA;
	private static int[] registerB;
	private static int[] bits = new int[] { 7, 6, 5, 4, 3, 2, 1, 0 };

	private static int[] converToBit(int value) {
		int[] out = new int[bits.length];
		int total = 0;
	
		for (int k = 0; k < bits.length; k++) {
			double curr = Math.pow(bits[k], 2);
			if (value < curr && (total + curr) < value) {
				out[k] = 1;
				total += curr;
			} else {
				out[k] = 0;
			}

			if (total == value)
				break;
		}
		
		return out;
	}

	private static int convertBitToValue(int[] register) {
		int value = 0;
		for (int k = 0; k < register.length; k++)
			if (register[k] != 0)
				value += Math.pow(register[k], bits[k]);
		return value;
	}

	private static String LEDRepresentation(int[] arr) {
		StringBuilder sb = new StringBuilder();
		for (int val: arr)
			if (val == 1)
				sb.append("*");
			else
				sb.append(".");
		return sb.toString();
	}

	private static void updateRegister(String s) {
		String[] tokens = s.split(",");
		if (tokens[0].equals("a"))
			registerA = converToBit(Integer.parseInt(tokens[1]));
		else
			registerB = converToBit(Integer.parseInt(tokens[1]));
	}

	private static boolean isRegisterValueZero(int[] register) {
		for (int val: register)
			if (val == 1)
				return false;
		return true;
	}

	private static void parseProgram() throws IOException {
		String inputFile = "input.in";
		String operation = "";
		List<String> lines = Files.readAllLines(Paths.get(inputFile), StandardCharsets.UTF_8);
		List<String> loopInstructions = new ArrayList<String>();
		List<String> collection = lines;

		main: for (int j = 0; j < collection.size(); j++) {
			String line = lines.get(j);

			int ldIdx = line.indexOf("ld");
			int ldOut = line.indexOf("out");
			int colmIdx = line.indexOf(":");

			if (ldIdx > 0) {
				updateRegister(line.substring(ldIdx + 2));		
			}

			int c = line.indexOf(",");
			if (ldOut > 0) {
				String s = line.charAt(c + 1) + "";
				String output = s.equals("a") ? LEDRepresentation(registerA) : LEDRepresentation(registerB);
				System.out.println(output);
			}

			if (colmIdx > 0) {
				operation = line.substring(0, colmIdx);		
				for (int q = j + 1; q < lines.size(); q++) {
					if (q == lines.size() - 1 && operation == "") {
						if (operation.equals("djnz") && !isRegisterValueZero(registerB)) {
							if (convertBitToValue(registerB) != 0) {
								j--;
								collection = loopInstructions;
							} else {
								break main;
							}
						}
					}
					loopInstructions.add(lines.get(q));
				}
			}
		}
	}

	public static void main(String... args) throws IOException {
		parseProgram();
	}
}
