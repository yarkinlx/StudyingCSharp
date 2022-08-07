// Условие задачи: Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.
// Что нужно сделать первым делом? → Уточнить задачу и понять, ясна ли задача. Что значит “Дан текст”? Что значит “черточками”? Какого алфавита? Маленькие буквы “к” заменить большими “К”, 
// а большие “С” заменить маленькими“
// Текст, в котором надо внести изменения:
// — Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. 
// Вы так красноречивы. Вы дадите мне чаю?


string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде,вы бы взяли приступом согласие прусского короля.Вы так красноречивы. Вы дадите мне чаю?";

string TextChange(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = TextChange(text, ' ' , '_');
Console.WriteLine(newText);
string newText2 = TextChange(newText, 'к' , 'К');
Console.WriteLine(newText2);
string newText3 = TextChange(newText2, 'С' , 'с');
Console.WriteLine(newText3);