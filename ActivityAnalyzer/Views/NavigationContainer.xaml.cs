namespace ActivityAnalyzer.Pages;

public partial class NavigationContainer : ContentPage
{
    private int _currentIndex = 0;
    public NavigationContainer()
    {
        InitializeComponent();

        //PagesCarousel.CurrentItemChanged += (s, e) =>
        //{
        //    var items = PagesCarousel.ItemsSource as List<ContentView>;
        //    if (items != null && PagesCarousel.CurrentItem != null)
        //    {
        //        _currentIndex = items.IndexOf((ContentView)PagesCarousel.CurrentItem);
        //    }
        //};

        //// Восстанавливаем страницу при изменении размера (появление/скрытие клавиатуры)
        //PagesCarousel.SizeChanged += (s, e) =>
        //{
        //    var items = PagesCarousel.ItemsSource as List<ContentView>;
        //    if (items != null && _currentIndex >= 0 && _currentIndex < items.Count)
        //    {
        //        PagesCarousel.CurrentItem = items[_currentIndex];
        //    }
        //};

        BindingContext = this;
    }

    public List<ContentView> Views => 
        [
            new MainView(),
            new HistoryView(),
            new RecommendatinView(),
            new GoalsView()
        ];
}
