
using Xunit;

var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var expected = new ListNode(1,
                new ListNode(1,
                 new ListNode(2,
                  new ListNode(3,
                   new ListNode(4,
                    new ListNode(4))))));

var result = MergeTwoLists(list1, list2);
Assert.Equal(expected, result);

static ListNode MergeTwoLists(ListNode l1, ListNode l2)
{
    var dummy = new ListNode(0);
    var tail = dummy;

    while (l1 != null && l2 != null)
    {
        if (l1.val >= l2.val)
        {
            tail.next = l2;
            l2 = l2.next;
        }
        else
        {
            tail.next = l1;
            l1 = l1.next;
        }

        tail = tail.next;
    }

    if (l1 != null)
        tail.next = l1;
    else if (l2 != null)
        tail.next = l2;

    return dummy.next;
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