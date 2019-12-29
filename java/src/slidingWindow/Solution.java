package slidingWindow;

import java.util.ArrayList;
import java.util.List;

class Solution {
    public List<Integer> findAnagrams(String s, String p) {
        List<Integer> result = new ArrayList<>();
        if (p.length() > s.length() || s.length() == 0)
            return result;
        int[] str = new int[26];
        int[] pattern = new int[26];
        for (int i = 0; i < p.length(); i++) {
            char c = p.charAt(i);
            pattern[c - 'a']++;
        }
        for (int i = 0; i < p.length(); i++) {
            char c = s.charAt(i);
            str[c - 'a']++;
        }
        if (compareTwoArray(str, pattern))
            result.add(0);
        int sliding_window_start_index = 1;
        for (int i = p.length(); i < s.length(); i++) {
            str[s.charAt(sliding_window_start_index - 1) - 'a']--;
            str[s.charAt(i) - 'a']++;
            if (compareTwoArray(str, pattern))
                result.add(sliding_window_start_index);
            sliding_window_start_index++;

        }
        return result;
    }

    private boolean compareTwoArray(int[] str, int[] pattern) {
        for (int i = 0; i < 26; i++) {
            if (str[i] != pattern[i])
                return false;
        }
        return true;
    }
}