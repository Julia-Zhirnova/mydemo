# mydemo
Полезно:
- плитка 
``` <ListView.ItemsPanel>
                <ItemsPanelTemplate>
                    <WrapPanel Orientation="Horizontal" HorizontalAlignment="Center"></WrapPanel>
                </ItemsPanelTemplate>
            </ListView.ItemsPanel>
- заливка
``` <ListView.ItemContainerStyle>
                <Style TargetType="ListViewItem">
                    <Style.Triggers>
                        <DataTrigger Binding="{Binding IsDiscount}" Value="True">
                            <Setter Property="Background" Value="LightGreen"/>
                        </DataTrigger>
                    </Style.Triggers>
                </Style>
            </ListView.ItemContainerStyle>  
            ```
        
- зачеркивание текста
```
<StackPanel Orientation="Horizontal">
                                <TextBlock TextDecorations="{Binding CostTextDecoration}" Text ="{Binding Cost, StringFormat={}{0:N0}}"  Margin="5 5 5 15"  FontSize="20"></TextBlock>
                                <TextBlock Text ="{Binding CostDis, StringFormat={}{0:N0} рублей}"  Margin="5 5 5 15"  FontSize="20"></TextBlock>
                                <TextBlock Text ="{Binding DurationInMinutes, StringFormat={}за {0} минут }" Margin="5 5 5 15" FontSize="20" ></TextBlock>
                            </StackPanel>
                            
          public string CostTextDecoration
        {
            get
            {
                return IsDiscount ? "Strikethrough" : "None";
            }
        }

Тестирование
![image](https://user-images.githubusercontent.com/52165649/162692770-4988b1f9-0570-490b-90f0-10331ab6866c.png)

 ВОПРОСЫ
 ПОСМОТРЕТЬ АВТОРИЗАЦИЮ
