Public Interface ICarnivore
    ReadOnly Property IsHungry As Boolean '手動添加唯讀修飾詞

    Sub Eat(Victim As VB_demo22.Animal)
    Function Hunt() As VB_demo22.Animal
End Interface
