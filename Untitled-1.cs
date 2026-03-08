def nfa_simulator(word):
    current_states = {'q1'}
    
    transitions = {
        'q1': {'a': {'q1'}, 'b': {'q2'}},
        'q2': {'a': {'q2'}, 'b': {'q3', 'q4'}},
        'q3': {'a': {'q3'}, 'b': {'q4'}},
        'q4': {'a': {'q4'}, 'b': {'q4'}}
    }
    
    accepting_states = {'q1', 'q3'}
    
    print(f"--- Аналіз слова: '{word}' ---")
    print(f"Старт: {current_states}")
    
    for char in word:
        if char not in ['a', 'b']:
            return "ПОМИЛКА: Символ не належить алфавіту Σ"
        
        next_possible_states = set()
        for state in current_states:
            if char in transitions[state]:
                next_possible_states.update(transitions[state][char])
        
        current_states = next_possible_states
        print(f"Символ '{char}' -> Можливі стани: {current_states}")
        
        if not current_states:
            break
    
    is_accepted = any(state in accepting_states for state in current_states)
    
    if is_accepted:
        return f"РЕЗУЛЬТАТ: Слово '{word}' ПРИЙНЯТО (зупинка на {current_states})"
    else:
        return f"РЕЗУЛЬТАТ: Слово '{word}' ВІДХИЛЕНО"

print(nfa_simulator("aab"))
print(nfa_simulator("abb"))
print(nfa_simulator("ab"))