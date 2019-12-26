package stack.decodeString;

import java.util.Stack;

class Solution {

    public String decodeString(String s) {
        Stack<Character> stack = new Stack();
        Stack<Integer> integerStack = new Stack<>();

        for (int i = 0; i < s.length(); i++) {
            char current = s.charAt(i);
            if (current != ']') {
                if (Character.isDigit(current)) {
                    int temp = 0;
                    while(Character.isDigit(s.charAt(i)))
                    {
                        temp = temp * 10 + Character.getNumericValue(s.charAt(i));
                        i++;
                    }
                    integerStack.push(temp);
                    i--;
                } else {
                    stack.push(current);
                }
            } else {
                StringBuilder str = new StringBuilder();

                while (stack.size() > 0) {
                    char c = stack.pop();
                    if (c != '[') {
                        str = str.insert(0, c);
                    } else if (c == '[') {
                        int times  = integerStack.pop();
                        eval(stack, str, times);
                        break;
                    }
                }
            }
        }
        StringBuilder result = new StringBuilder();
        while (stack.size() > 0) {
            result.insert(0, stack.pop());
        }
        return result.toString();
    }

    private void eval(Stack<Character> stack, StringBuilder str, int times) {
        StringBuilder s = new StringBuilder();
        for (int j = 0; j < times; j++) {
            s.append(str);
        }
        for (int j = 0; j < s.length(); j++) {
            stack.push(s.charAt(j));
        }
    }
}