document.getElementById('submitButton').addEventListener('click', async () => {
    const selectedAnswers = Array.from(document.querySelectorAll('input[type=radio]:checked')).map(el => el.value);

    try {
        await fetch('/api/SubmitQuiz', {
            method: 'POST',
            body: JSON.stringify({ SelectedAnswersIds: selectedAnswers })
        });

        alert('Результаты успешно отправлены!');
    } catch (error) {
        console.error('Ошибка при отправке результатов: ', error);
    }
});