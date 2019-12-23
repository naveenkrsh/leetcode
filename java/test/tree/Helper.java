package tree;

public class Helper {

    public static TreeNode buildTree(Integer[] arr)
    {
        return buildTreeUtil(arr,null,0);
    }

    private static TreeNode buildTreeUtil(Integer[] arr, TreeNode root,int index)
    {
        if(index < arr.length )
        {
            if(arr[index] == null)
                return null;
            TreeNode temp = new TreeNode(arr[index]);
            root = temp;

            root.left = buildTreeUtil(arr, root.left,2*index +1);
            root.right = buildTreeUtil(arr, root.right,2*index +2);

        }
        return  root;
    }
}
