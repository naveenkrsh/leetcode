package tree;

import java.util.LinkedList;
import java.util.Queue;

public class Helper {

    public static TreeNode buildTree(Integer[] arr) {
        return buildTreeUtil(arr, null, 0);
    }

    private static TreeNode buildTreeUtil(Integer[] arr, TreeNode root, int index) {
        if (index < arr.length) {
            if (arr[index] == null)
                return null;
            TreeNode temp = new TreeNode(arr[index]);
            root = temp;
            root.left = buildTreeUtil(arr, root.left, 2 * index + 1);
            root.right = buildTreeUtil(arr, root.right, 2 * index + 2);
        }
        return root;
    }

    public static TreeNode stringToTreeNode(String input) {
        input = input.trim();
        input = input.substring(1, input.length() - 1);
        if (input.length() == 0) {
            return null;
        }

        String[] parts = input.split(",");
        String item = parts[0];
        TreeNode root = new TreeNode(Integer.parseInt(item));
        Queue<TreeNode> nodeQueue = new LinkedList<>();
        nodeQueue.add(root);

        int index = 1;
        while (!nodeQueue.isEmpty()) {
            TreeNode node = nodeQueue.remove();

            if (index == parts.length) {
                break;
            }

            item = parts[index++];
            item = item.trim();
            if (!item.equals("null")) {
                int leftNumber = Integer.parseInt(item);
                node.left = new TreeNode(leftNumber);
                nodeQueue.add(node.left);
            }

            if (index == parts.length) {
                break;
            }

            item = parts[index++];
            item = item.trim();
            if (!item.equals("null")) {
                int rightNumber = Integer.parseInt(item);
                node.right = new TreeNode(rightNumber);
                nodeQueue.add(node.right);
            }
        }
        return root;
    }
}
