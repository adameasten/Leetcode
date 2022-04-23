using Xunit;

var input = CreateLinkedList(new int[] { 1, 2, 3, 4, 5 });
var expected = new int[] { 1, 2, 3, 5 };
var result = RemoveNthFromEnd(input, 2);
var ouput = DeconstructLinkedList(result);

Assert.Equal(expected, ouput);

static ListNode RemoveNthFromEnd(ListNode head, int n)
{
    var dummy = new ListNode(0, head);

    var left = dummy;
    var right = head;

    while (n > 0 && right != null)
    {
        right = right.next;
        n--;
    }

    while (right != null)
    {
        left = left.next;
        right = right.next;
    }

    //delete
    left.next = left.next.next;

    //Return linked list
    return dummy.next;
}

static ListNode CreateLinkedList(int[] input)
    => new ListNode(input[0],
        new ListNode(input[1],
          new ListNode(input[2],
            new ListNode(input[3],
              new ListNode(input[4])))));

static int[] DeconstructLinkedList(ListNode head)
{
    var current = head;
    var values = new List<int>();

    while (current != null)
    {
        values.Add(current.val);
        current = current.next;
    }

    return values.ToArray();
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}