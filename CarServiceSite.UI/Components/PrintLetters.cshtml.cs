using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class PrintLettersModel : PageModel
    {
        public char[] Letters { get; } = { 'A', 'B', 'C', 'D', 'E' };

        public void OnGet()
        {
            // ����� ����� �������� ������ ����� ������� ��������, ���� �����.
            // � ������ ������� ��� ���� �� ���������.
        }
    }
}