public class KaprekarNumber {
	public static void main(String... args) {
		System.out.println(K(2, 1000));
	}

	private static String K(int s, int e) {
		StringBuilder sb = new StringBuilder();
		for (int i = s; i <= e; i++) {
			double pow = Math.pow(i, 2);
			String powStr = Double.toString(pow);
			int idx = powStr.indexOf(".");
			powStr = powStr.substring(0, idx);

			if (powStr.length() > 1) {
				for (int k = 1; k < powStr.length(); k++) {
					int left = Integer.parseInt(powStr.substring(0, k));
					int right = Integer.parseInt(powStr.substring(k));

					if (left < i && right < i) {
						if (left + right == i) {
							sb.append(String.format("%d ", i));
						}
					}
				}
			}
		}
		
		return sb.toString();
	}
}
