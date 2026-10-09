public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {

        // Update the Insert function of the Node class to only allow unique values to be added to the tree
        if (value == Data)
            return; // Value already exists, so don't add it

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // Update the Contains function of the Node class to return true if the value exists in the tree, and false otherwise
        if (value == Data)
            return true;
        
        if (value < Data)
        {
            // Search to the left
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // Search to the right
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Update the GetHeight function of the Node class to return the height of the tree 

        if (Left is null && Right is null)
            return 1; // Leaf node
        else
        {
            int leftHeight = Left?.GetHeight() ?? 0;
            int rightHeight = Right?.GetHeight() ?? 0;
            return 1 + Math.Max(leftHeight, rightHeight);
        }
        
    }
}