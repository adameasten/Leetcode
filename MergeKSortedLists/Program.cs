
using MergeKSortedLists;

var one = new ListNode(1, new ListNode(4, new ListNode(5)));
var two = new ListNode(1, new ListNode(3, new ListNode(4)));
var three = new ListNode(2, new ListNode(6));

var input = new ListNode[] { one, two, three };
var result = MergeKLists(input);

//Manual assert
//result.Should().Be => 1,1,2,3,4,4,5,6

static ListNode MergeKLists(ListNode[] lists)
{
    do
    {
        var mergedLists = new List<ListNode>();

        for (int i = 0; i < lists.Length; i += 2)
        {
            var current = lists[i];
            var next = i + 1 < lists.Length ? lists[i + 1] : null;

            mergedLists.Add(MergeTwoLists(current, next));
        }

        lists = mergedLists.ToArray();

    } while (lists.Length > 1);

    return lists[0];
}

static ListNode MergeTwoLists(ListNode l1, ListNode l2)
{
    var dummy = new ListNode();
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